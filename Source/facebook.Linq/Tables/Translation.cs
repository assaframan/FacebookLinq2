using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;
using Facebook;

namespace facebook.Tables
{
    /// <summary>
    /// https://developers.facebook.com/docs/reference/fql/translation
    /// </summary>
    [Table(Name = "translation")]
    public class Translation
    {
        /// <summary>
        /// The approval status of the string. The status is one of:
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "approval_status" , IsPrimaryKey = true)]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// The translated string that gets displayed to a user translating your application. The user must be browsing Facebook in the locale of the approved translation. Querying on this column returns either a native string or translated string. If no entry for the corresponding native string exists in the Translations database, this column returns null
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "best_string" )]
        public string BestString { get; set; }

        /// <summary>
        /// The description of the native string needing translation. This text clarifies the context in which the text is used, and the meaning if it is ambiguous. This is shown to translators in the bulk translation user interface, among other places, and should describe the text well enough that someone can translate it without seeing it in the context of your application. In general a piece of text should always have a description unless it is a complete sentence whose meaning would be clear to a user who has never seen your application. If a description for the corresponding string or hash doesn't exist in the Translations database, this column returns null. Description for a string should be in the same language as the string itself
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// Whether the string is translatable. Strings are translatable only when the user making the request is in in translation mode and there's content yet unapproved
        /// 
        /// original type is: number (min: 0) (max: 1)
        /// </summary>
        [Column(Name = "is_translatable" )]
        public object IsTranslatable { get; set; }

        /// <summary>
        /// The locale for the translations for which you are querying. You can specify a locale of user to default to the session user's current locale. See Facebook Locales for the list of currently  supported locales. You must specify a single locale in your query
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "locale" )]
        public string Locale { get; set; }

        /// <summary>
        /// A hash of the native string and a description. It's a unique identifier for the string. Query on this column to quickly return your application's native strings and their descriptions
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "native_hash" )]
        public string NativeHash { get; set; }

        /// <summary>
        /// The actual text from your application you previously submitted for translation to the Translations application
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "native_string" )]
        public string NativeString { get; set; }

        /// <summary>
        /// A concatenation of the native string and its description. This string is used to generate the native hash. The native string is concatenated with 3 colons, the description, then another colon. Query on this column if you want to check whether a random string and description exists. A query containing the pre_hash_string runs more slowly than a query containing the native_hash
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pre_hash_string" )]
        public string PreHashString { get; set; }

        /// <summary>
        /// The translation of the native string. If a translation for the corresponding string or hash doesn't exist in the Translations database, this column returns null
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "translation" )]
        public string Translation_ { get; set; }

        /// <summary>
        /// ID of the translation
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "translation_id" )]
        public string TranslationId { get; set; }

    }
}
