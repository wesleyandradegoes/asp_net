using System.ComponentModel;
using System.Runtime.Serialization;

namespace CRUD_Clientes_CRMALL
{
    public enum Estado
    {
        [EnumMember(Value = "1")]
        [Description("Acre")]
        AC = 1,
        [EnumMember(Value = "2")]
        [Description("Alagoas")]
        AL,
        [EnumMember(Value = "3")]
        [Description("Amapá")]
        AP,
        [EnumMember(Value = "4")]
        [Description("Amazonas")]
        AM,
        [EnumMember(Value = "5")]
        [Description("Bahia")]
        BA,
        [EnumMember(Value = "6")]
        [Description("Ceará")]
        CE,
        [EnumMember(Value = "7")]
        [Description("Distrito Federal")]
        DF,
        [EnumMember(Value = "8")]
        [Description("Espirito Santo")]
        ES,
        [EnumMember(Value = "9")]
        [Description("Goiás")]
        GO,
        [EnumMember(Value = "10")]
        [Description("Maranhão")]
        MA,
        [EnumMember(Value = "11")]
        [Description("Mato Grosso")]
        MT,
        [EnumMember(Value = "12")]
        [Description("Mato Grosso do Sul")]
        MS,
        [EnumMember(Value = "13")]
        [Description("Minas Gerais")]
        MG,
        [EnumMember(Value = "14")]
        [Description("Pará")]
        PA,
        [EnumMember(Value = "15")]
        [Description("Paraiba")]
        PB,
        [EnumMember(Value = "16")]
        [Description("Paraná")]
        PR,
        [EnumMember(Value = "17")]
        [Description("Pernambuco")]
        PE,
        [EnumMember(Value = "18")]
        [Description("Piauí")]
        PI,
        [EnumMember(Value = "19")]
        [Description("Rio de Janeiro")]
        RJ,
        [EnumMember(Value = "20")]
        [Description("Rio Grande do Norte")]
        RN,
        [EnumMember(Value = "21")]
        [Description("Rio Grande do Sul")]
        RS,
        [EnumMember(Value = "22")]
        [Description("Rondônia")]
        RO,
        [EnumMember(Value = "23")]
        [Description("Roraima")]
        RR,
        [EnumMember(Value = "24")]
        [Description("Santa Catarina")]
        SC,
        [EnumMember(Value = "25")]
        [Description("São Paulo")]
        SP,
        [EnumMember(Value = "26")]
        [Description("Sergipe")]
        SE,
        [EnumMember(Value = "27")]
        [Description("Tocantis")]
        TO
    }
}