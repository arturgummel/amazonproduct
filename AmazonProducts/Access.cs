using AmazonProducts.LocaleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonProducts
{
    public class Access
    {
        public const String ACCESS_KEY_ID = "AKIAICAGEPHAX2FWHN5A";
        public const String SECRET_KEY = "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";
        public const String ASSOCIATE_TAG = "224283415179";

        public const int AMAZON_API_MAX_PRODUCTS_PER_PAGE = 10;
        public const int AMAZON_API_MAX_PAGES_INDEX_ALL = 5; // Max pages when searchindex = All
        public const int AMAZON_API_MAX_PAGES_INDEX_OTHER = 10; // Max pages when index != All

        public static LocaleDefinition CURRENT_LOCALE = new UkLocale();
        public const int PRODUCTS_PER_PAGE = 13;
    }
}