using System.Text;

namespace CustomerManagement
{
    public static class Constants
    {
        public static readonly UTF8Encoding utf8Encoding = new UTF8Encoding(true);

        public static readonly string WindowsDrive = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))!;

        public static readonly string DataDirectoryName = "CLINICA ESTETICA";

        public static readonly string DataDirectoryPath = Path.Combine(
            path1: WindowsDrive,
            path2: DataDirectoryName
        );

        public static readonly string DataFilePath = Path.Combine(
            path1: Constants.DataDirectoryPath,
            path2: "clientes.xlsx"
        );

        public static readonly Dictionary<string, string[]> worksheetsMapping = new Dictionary<string, string[]>
        {
            {
                "Clientes", new[] {
                    "Id",
                    "Nome Completo",
                    "RG",
                    "CPF",
                    "Data de Nascimento",
                    "Endereço",
                    "CEP",
                    "Cidade",
                    "Email",
                    "WhatsApp",
                    "Telefone Fixo"
                }
            }
        };
    }
}
