using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.Payments.PhonePe.Models
{
    public class ConfigurationModel : BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PhonePe.Fields.UseSandbox")]
        public bool UseSandbox { get; set; }
        public bool UseSandbox_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PhonePe.Fields.SandboxURL")]
        public string SandboxURL { get; set; }
        public bool SandboxURL_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PhonePe.Fields.ProductionURL")]
        public string ProductionURL { get; set; }
        public bool ProductionURL_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PhonePe.Fields.MerchantId")]
        public string MerchantId { get; set; }
        public bool MerchantId_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PhonePe.Fields.Salt")]
        public string Salt { get; set; }
        public bool Salt_OverrideForStore { get; set; }

        //[NopResourceDisplayName("Plugins.Payments.PhonePe.Fields.BusinessEmail")]
        //public string BusinessEmail { get; set; }
        //public bool BusinessEmail_OverrideForStore { get; set; }

        //[NopResourceDisplayName("Plugins.Payments.PhonePe.Fields.PDTToken")]
        //public string PdtToken { get; set; }
        //public bool PdtToken_OverrideForStore { get; set; }

        //[NopResourceDisplayName("Plugins.Payments.PhonePe.Fields.PassProductNamesAndTotals")]
        //public bool PassProductNamesAndTotals { get; set; }
        //public bool PassProductNamesAndTotals_OverrideForStore { get; set; }

        //[NopResourceDisplayName("Plugins.Payments.PhonePe.Fields.AdditionalFee")]
        //public decimal AdditionalFee { get; set; }
        //public bool AdditionalFee_OverrideForStore { get; set; }

        //[NopResourceDisplayName("Plugins.Payments.PhonePe.Fields.AdditionalFeePercentage")]
        //public bool AdditionalFeePercentage { get; set; }
        //public bool AdditionalFeePercentage_OverrideForStore { get; set; }
    }
}