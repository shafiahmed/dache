﻿using System.Configuration;

namespace Dache.Client.Configuration
{
    /// <summary>
    /// Provides a custom type element for configuration.
    /// </summary>
    public class CustomTypeElement : ConfigurationElement
    {
        /// <summary>
        /// The custom type.
        /// </summary>
        [StringValidator(InvalidCharacters = @"\: ")]
        [ConfigurationProperty("type", IsRequired = true)]
        public string Type
        {
            get
            {
                return (string)this["type"];
            }
            set
            {
                this["type"] = value;
            }
        }
    }
}
