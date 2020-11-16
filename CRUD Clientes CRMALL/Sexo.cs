using System.ComponentModel;
using System.Runtime.Serialization;

namespace CRUD_Clientes_CRMALL
{
    public enum Sexo
    {
        [EnumMember(Value = "1")]
        [Description("Masculino")]
        Masculino = 1,
        [EnumMember(Value = "2")]
        [Description("Feminino")]
        Feminino = 2
    }
}