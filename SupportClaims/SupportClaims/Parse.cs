using System;
using Newtonsoft.Json;

namespace SupportClaims
{
    public class Parse
    {
        [JsonArray]
        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }
        public class Class1
        {
            public Key key { get; set; }
            public string number { get; set; }
            public string interactionMethod { get; set; }
            public Interactionmethoddisplay interactionMethodDisplay { get; set; }
            public string sourceType { get; set; }
            public Sourcetypedisplay sourceTypeDisplay { get; set; }
            public string objectType { get; set; }
            public Objecttypedisplay objectTypeDisplay { get; set; }
            public int classification { get; set; }
            public Classificationdisplay classificationDisplay { get; set; }
            public int category { get; set; }
            public Categorydisplay categoryDisplay { get; set; }
            public string invoiceNumber { get; set; }
            public string ptNumber { get; set; }
            public string problemDescription { get; set; }
            public string priority { get; set; }
            public string assignedToOperatorName { get; set; }
            public string authorName { get; set; }
            public string status { get; set; }
            public string clientName { get; set; }
            public object deferredUntil { get; set; }
            public DateTime creationTime { get; set; }
            public object closingTime { get; set; }
            public string customerName { get; set; }
            public object sourceEmailRecipient { get; set; }
            public object sourceEmailSender { get; set; }
            public Techdata techData { get; set; }
        }

        public class Key
        {
            public int id { get; set; }
            public int ownerId { get; set; }
        }

        public class Interactionmethoddisplay
        {
            public int value { get; set; }
            public string displayName { get; set; }
            public string cSharpName { get; set; }
        }

        public class Sourcetypedisplay
        {
            public int value { get; set; }
            public string displayName { get; set; }
            public string cSharpName { get; set; }
        }

        public class Objecttypedisplay
        {
            public int value { get; set; }
            public string displayName { get; set; }
            public string cSharpName { get; set; }
        }

        public class Classificationdisplay
        {
            public int value { get; set; }
            public string displayName { get; set; }
            public string cSharpName { get; set; }
        }

        public class Categorydisplay
        {
            public int value { get; set; }
            public string displayName { get; set; }
            public string cSharpName { get; set; }
        }

        public class Techdata
        {
            public string status { get; set; }
            public string content { get; set; }
        }
    }
}