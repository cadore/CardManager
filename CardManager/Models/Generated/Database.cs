using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;
using ModelsCardManager.Utils;
using CardManager.Connection;

namespace CardManagerRepo
{

	public partial class CardRepo : Database
	{
        public CardRepo() : base(ConnectionUtil.ConnectionString, ConnectionUtil.InvariantName)
		{
			CommonConstruct();
		}

		public CardRepo(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
            CardRepo GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static CardRepo GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
                return new CardRepo();
        }

        [ThreadStatic]
        static CardRepo _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
            public static CardRepo repo { get { return CardRepo.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }
            public static String Concat(object o) { return String.Format("%{0}%", o); }
            public static DateTime Now()
            {
                bool web = Util.isConnectedWeb();
                if (web)
                    return Dates.getUTCDateTime();
                else
                    return repo.ExecuteScalar<DateTime>("SELECT LOCALTIMESTAMP");
            }

		}
	}
    [PrimaryKey("id")]
    [ExplicitColumns]
    [TableName("customers")]
    public class customer : CardRepo.Record<customer>
    {
        [Column]
        public long id { get; set; }
        [Column]
        public string name { get; set; }
        [Column]
        public DateTime? birthday { get; set; }
        [Column]
        public DateTime registered_at { get; set; }
        [Column]
        public string rg { get; set; }
        [Column]
        public string organ_emitter_rg { get; set; }
        [Column]
        public string cpf { get; set; }
        [Column]
        public long address_id { get; set; }
        [Column]
        public string observation { get; set; }
        [Column]
        public bool inactive { get; set; }
        [Column]
        public DateTime? inactive_at { get; set; }
        [Column]
        public string mail { get; set; }
        [Column]
        public string mail_other { get; set; }
        [Column]
        public long business_id { get; set; }
        [Column]
        public DateTime? emission_card_at { get; set; }
        [Column]
        public DateTime? last_using { get; set; }
        [Column]
        public string barcode { get; set; }
        [Column]
        public bool card_emitted { get; set; }
        [Column]
        public decimal value_card { get; set; }
        [Column]
        public DateTime? validate_card { get; set; }
        [Column]
        public string directory_picture { get; set; }
        [Column]
        public long registred_by { get; set; }
        [Column]
        public long emission_card_by { get; set; }

        public void CreateCardCode()
        {
            this.barcode = CardUtils.GenerateCardCode(this);
        }
    }

    [TableName("address")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public class address : CardRepo.Record<address>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public string name { get; set; }

        [Column]
        public string district { get; set; }

        [Column]
        public long city_id { get; set; }

        [Column]
        public long state_id { get; set; }

        [Column]
        public string number { get; set; }

        [Column]
        public string complement { get; set; }

        [Column]
        public string cep { get; set; }
    }
    [TableName("receipts_credentialeds")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public class receipts_credentialeds : CardRepo.Record<receipts_credentialeds>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public long credentialed_id { get; set; }

        [Column]
        public int month { get; set; }

        [Column]
        public int year { get; set; }

        [Column]
        public decimal value { get; set; }

        [Column]
        public DateTime date { get; set; }
        [Column]
        public string observations { get; set; }
        public string credentialed_name { get; set; }
    }
    [ExplicitColumns]
    [TableName("business")]
    [PrimaryKey("id")]
    public class business : CardRepo.Record<business>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public string cnpj { get; set; }

        [Column]
        public string corporate_name { get; set; }

        [Column]
        public string fantasy_name { get; set; }

        [Column]
        public long address_id { get; set; }

        [Column]
        public string email_principal { get; set; }

        [Column]
        public string email_contato { get; set; }

        [Column]
        public string phone_principal { get; set; }

        [Column]
        public string phone_mobile { get; set; }

        [Column]
        public string link_site { get; set; }

        [Column]
        public string link_sistema { get; set; }

        [Column]
        public string directory_logo { get; set; }
    }
    [PrimaryKey("id")]
    [TableName("city")]
    [ExplicitColumns]
    public class city : CardRepo.Record<city>
    {
        [Column]
        public int id { get; set; }

        [Column]
        public string name { get; set; }

        [Column]
        public int cod_ibge { get; set; }

        [Column]
        public int state_id { get; set; }

        [Column]
        public int population { get; set; }

        [Column]
        public Decimal demographic { get; set; }

        [Column]
        public string gentilic { get; set; }

        [Column]
        public Decimal area { get; set; }

        [Column]
        public string zip_code { get; set; }
    }
    [ExplicitColumns]
    [TableName("credentialeds")]
    [PrimaryKey("id")]
    public class credentialed : CardRepo.Record<credentialed>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public string cnpj { get; set; }

        [Column]
        public string company_name { get; set; }

        [Column]
        public string fantasy_name { get; set; }

        [Column]
        public DateTime? opening_at { get; set; }

        [Column]
        public string phone_fixed { get; set; }

        [Column]
        public string phone_mobile { get; set; }

        [Column]
        public long address_id { get; set; }

        [Column]
        public bool inactive { get; set; }

        [Column]
        public string description_discount { get; set; }

        [Column]
        public Decimal value_discount { get; set; }

        [Column]
        public string directory_logo { get; set; }

        [Column]
        public DateTime? registered_at { get; set; }

        [Column]
        public DateTime? inactived_at { get; set; }

        [Column]
        public string observations { get; set; }

        [Column]
        public long business_id { get; set; }

        [Column]
        public string password { get; set; }
    }
    [PrimaryKey("id")]
    [ExplicitColumns]
    [TableName("phones_customers")]
    public class phones_customer : CardRepo.Record<phones_customer>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public long customer_id { get; set; }

        [Column]
        public string phone { get; set; }
    }
    [PrimaryKey("id")]
    [ExplicitColumns]
    [TableName("users")]
    public class user : CardRepo.Record<user>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public string full_name { get; set; }

        [Column]
        public string cpf { get; set; }

        [Column]
        public string phone { get; set; }

        [Column]
        public string password { get; set; }

        [Column]
        public bool inactive { get; set; }

        [Column]
        public long business_id { get; set; }

        [Column]
        public bool change_business { get; set; }
    }
    [TableName("organs_emitters")]
    [ExplicitColumns]
    [PrimaryKey("id")]
    public class organ_emitter : CardRepo.Record<organ_emitter>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public string name { get; set; }

        [Column]
        public string symbol { get; set; }
    }
    [TableName("uses_of_cards")]
    [ExplicitColumns]
    [PrimaryKey("id")]
    public class uses_of_card : CardRepo.Record<uses_of_card>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public long credentialed_id { get; set; }

        [Column]
        public long customer_id { get; set; }

        [Column]
        public long card_id { get; set; }

        [Column]
        public long user_id { get; set; }

        [Column]
        public DateTime use_at { get; set; }

        [Column]
        public Decimal discount { get; set; }

        [Column]
        public int type { get; set; }

        [Column]
        public long business_id { get; set; }
    }
    [ExplicitColumns]
    [PrimaryKey("id")]
    [TableName("states")]
    public class state : CardRepo.Record<state>
    {
        [Column]
        public int id { get; set; }

        [Column]
        public string name { get; set; }

        [Column]
        public string symbol { get; set; }
    }
    [ExplicitColumns]
    [PrimaryKey("id")]
    [TableName("sms")]
    public class sms : CardRepo.Record<sms>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public string message { get; set; }

        [Column]
        public DateTime send_at { get; set; }

        [Column]
        public string receiver { get; set; }

        [Column]
        public string status { get; set; }
        [Column]
        public string serial { get; set; }
    }
    [PrimaryKey("id")]
    [TableName("resposibles_credentialeds")]
    [ExplicitColumns]
    public class resposibles_credentialed : CardRepo.Record<resposibles_credentialed>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public string full_name { get; set; }

        [Column]
        public string cpf { get; set; }

        [Column]
        public string phone_mobile { get; set; }

        [Column]
        public string phone_home { get; set; }

        [Column]
        public string email { get; set; }

        [Column]
        public long credentialed_id { get; set; }
    }
    [TableName("renovations_card")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public class renovations_card : CardRepo.Record<renovations_card>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public long customer_id { get; set; }

        [Column]
        public DateTime renovation_at { get; set; }

        [Column]
        public Decimal value_renovation { get; set; }

        [Column]
        public bool new_card { get; set; }
    }
    [TableName("outputs")]
    [ExplicitColumns]
    [PrimaryKey("id")]
    public class output : CardRepo.Record<output>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public string description { get; set; }

        [Column]
        public Decimal value { get; set; }

        [Column]
        public DateTime? registred_at { get; set; }

        [Column]
        public DateTime? date { get; set; }

        [Column]
        public long registred_by { get; set; }

        [Column]
        public string observations { get; set; }
    }
    [TableName("logins")]
    [ExplicitColumns]
    [PrimaryKey("id")]
    public class logins : CardRepo.Record<logins>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public long user_id { get; set; }

        [Column]
        public DateTime date { get; set; }

        [Column]
        public string computer { get; set; }

        [Column]
        public string local_ip { get; set; }

        [Column]
        public string external_ip { get; set; }
    }
    [PrimaryKey("id")]
    [TableName("inputs")]
    [ExplicitColumns]
    public class input : CardRepo.Record<input>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public long customer_id { get; set; }

        [Column]
        public long credentialed_id { get; set; }

        [Column]
        public string description { get; set; }

        [Column]
        public Decimal value { get; set; }

        [Column]
        public DateTime? registred_at { get; set; }

        [Column]
        public DateTime? date { get; set; }

        [Column]
        public long registred_by { get; set; }

        [Column]
        public string observations { get; set; }
    }
    [TableName("reasons_outputs")]
    [ExplicitColumns]
    [PrimaryKey("id")]
    public class reasons_outputs : CardRepo.Record<reasons_outputs>
    {
        [Column]
        public long id { get; set; }

        [Column]
        public string description { get; set; }
    }
}



