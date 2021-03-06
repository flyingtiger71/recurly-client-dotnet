/**
 * This file is automatically created by Recurly's OpenAPI generation process
 * and thus any edits you make by hand will be lost. If you wish to make a
 * change to this file, please create a Github issue explaining the changes you
 * need and we will usher them to the appropriate places.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Recurly.Resources
{
    [ExcludeFromCodeCoverage]
    public class AddOnMini : Resource
    {

        /// <value>Accounting code for invoice line items for this add-on. If no value is provided, it defaults to add-on's code.</value>
        [JsonProperty("accounting_code")]
        public string AccountingCode { get; set; }

        /// <value>The unique identifier for the add-on within its plan.</value>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <value>Optional, stock keeping unit to link the item to other inventory systems.</value>
        [JsonProperty("external_sku")]
        public string ExternalSku { get; set; }

        /// <value>Add-on ID</value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <value>Item ID</value>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <value>Describes your add-on and will appear in subscribers' invoices.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <value>Object type</value>
        [JsonProperty("object")]
        public string Object { get; set; }

    }
}
