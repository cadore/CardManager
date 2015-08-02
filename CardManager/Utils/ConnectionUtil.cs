using CardManagerRepo;
using ModelsCardManager.Utils;
using System;

namespace CardManager.Connection
{
    public class ConnectionUtil
    {
        public string Host { get; private set; }
        public string Port { get; private set; }
        public string DataBase { get; private set; }
        public string User { get; private set; }
        public string Password { get; private set; }

        public static string InvariantName { get; private set; }
        public static string ConnectionString { get; private set; }

        public ConnectionUtil()
        {
            try
            {
                Host = Util.Decrypt(INI.ReadValue("CONNECTION", "host"));
                Port = Util.Decrypt(INI.ReadValue("CONNECTION", "port"));
                DataBase = Util.Decrypt(INI.ReadValue("CONNECTION", "db"));
                User = Util.Decrypt(INI.ReadValue("CONNECTION", "user"));
                Password = Util.Decrypt(INI.ReadValue("CONNECTION", "password"));
                InvariantName = Util.Decrypt(INI.ReadValue("CONNECTION", "invariantName"));

                ConnectionString = String.Format("Server={0};Port={1};User id={2};password={3};Database={4};",
                Host, Port, User, Password, DataBase);

                business b = business.SingleOrDefault("WHERE cnpj=@0", Util.Decrypt(INI.ReadValue("SYSTEM", "business")));
                if (b == null)
                {
                    throw new Exception("Não foi possivel carregar os dados da empresa, empresa nao encontrada!");
                }
                Singleton.setCurrentBusiness(b);
            }
            catch (Exception ex)
            {
                ConnectionString = null;
                InvariantName = null;
                Singleton.setCurrentBusiness(null);
                throw new Exception(ex.Message, ex.InnerException);
            }           
        }
    }
}
