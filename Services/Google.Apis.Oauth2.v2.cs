//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Oauth2.v2.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Tokeninfo {
        
        private string _access_type;
        
        private string _audience;
        
        private string _email;
        
        private System.Nullable<long> _expires_in;
        
        private string _issued_to;
        
        private string _scope;
        
        private string _user_id;
        
        private System.Nullable<bool> _verified_email;
        
        /// <summary>The access type granted with this toke. It can be offline or online.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access_type")]
        public virtual string Access_type {
            get {
                return this._access_type;
            }
            set {
                this._access_type = value;
            }
        }
        
        /// <summary>Who is the intended audience for this token. In general the same as issued_to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience {
            get {
                return this._audience;
            }
            set {
                this._audience = value;
            }
        }
        
        /// <summary>The email address of the user. Present only if the email scope is present in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email {
            get {
                return this._email;
            }
            set {
                this._email = value;
            }
        }
        
        /// <summary>The expiry time of the token, as number of seconds left until expiry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expires_in")]
        public virtual System.Nullable<long> Expires_in {
            get {
                return this._expires_in;
            }
            set {
                this._expires_in = value;
            }
        }
        
        /// <summary>To whom was the token issued to. In general the same as audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issued_to")]
        public virtual string Issued_to {
            get {
                return this._issued_to;
            }
            set {
                this._issued_to = value;
            }
        }
        
        /// <summary>The space separated list of scopes granted to this token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope {
            get {
                return this._scope;
            }
            set {
                this._scope = value;
            }
        }
        
        /// <summary>The Gaia obfuscated user id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user_id")]
        public virtual string User_id {
            get {
                return this._user_id;
            }
            set {
                this._user_id = value;
            }
        }
        
        /// <summary>Boolean flag which is true if the email address is verified. Present only if the email scope is present in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verified_email")]
        public virtual System.Nullable<bool> Verified_email {
            get {
                return this._verified_email;
            }
            set {
                this._verified_email = value;
            }
        }
    }
    
    public class Userinfo : Google.Apis.Requests.IDirectResponseSchema {
        
        private string _birthday;
        
        private string _email;
        
        private string _family_name;
        
        private string _gender;
        
        private string _given_name;
        
        private string _id;
        
        private string _link;
        
        private string _locale;
        
        private string _name;
        
        private string _picture;
        
        private string _timezone;
        
        private System.Nullable<bool> _verified_email;
        
        private Google.Apis.Requests.RequestError _Error;
        
        private string _ETag;
        
        [Newtonsoft.Json.JsonPropertyAttribute("birthday")]
        public virtual string Birthday {
            get {
                return this._birthday;
            }
            set {
                this._birthday = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email {
            get {
                return this._email;
            }
            set {
                this._email = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("family_name")]
        public virtual string Family_name {
            get {
                return this._family_name;
            }
            set {
                this._family_name = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual string Gender {
            get {
                return this._gender;
            }
            set {
                this._gender = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("given_name")]
        public virtual string Given_name {
            get {
                return this._given_name;
            }
            set {
                this._given_name = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link {
            get {
                return this._link;
            }
            set {
                this._link = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale {
            get {
                return this._locale;
            }
            set {
                this._locale = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("picture")]
        public virtual string Picture {
            get {
                return this._picture;
            }
            set {
                this._picture = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("timezone")]
        public virtual string Timezone {
            get {
                return this._timezone;
            }
            set {
                this._timezone = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("verified_email")]
        public virtual System.Nullable<bool> Verified_email {
            get {
                return this._verified_email;
            }
            set {
                this._verified_email = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this._Error;
            }
            set {
                this._Error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
}
namespace Google.Apis.Oauth2.v2 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class Oauth2Service : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService _service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"discoveryVersion\":\"v1\",\"id\":\"oauth2:v2\",\"nam" +
            "e\":\"oauth2\",\"version\":\"v2\",\"revision\":\"20120423\",\"description\":\"OAuth2 API\",\"ico" +
            "ns\":{\"x16\":\"http://www.google.com/images/icons/product/search-16.gif\",\"x32\":\"htt" +
            "p://www.google.com/images/icons/product/search-32.gif\"},\"protocol\":\"rest\",\"baseU" +
            "rl\":\"https://www.googleapis.com/\",\"basePath\":\"/\",\"rootUrl\":\"https://www.googleap" +
            "is.com/\",\"servicePath\":\"/\",\"batchPath\":\"batch\",\"parameters\":{\"alt\":{\"type\":\"stri" +
            "ng\",\"description\":\"Data format for the response.\",\"default\":\"json\",\"enum\":[\"json" +
            "\"],\"enumDescriptions\":[\"Responses with Content-Type of application/json\"],\"locat" +
            "ion\":\"query\"},\"fields\":{\"type\":\"string\",\"description\":\"Selector specifying which" +
            " fields to include in a partial response.\",\"location\":\"query\"},\"key\":{\"type\":\"st" +
            "ring\",\"description\":\"API key. Your API key identifies your project and provides " +
            "you with API access, quota, and reports. Required unless you provide an OAuth 2." +
            "0 token.\",\"location\":\"query\"},\"oauth_token\":{\"type\":\"string\",\"description\":\"OAut" +
            "h 2.0 token for the current user.\",\"location\":\"query\"},\"prettyPrint\":{\"type\":\"bo" +
            "olean\",\"description\":\"Returns response with indentations and line breaks.\",\"defa" +
            "ult\":\"true\",\"location\":\"query\"},\"quotaUser\":{\"type\":\"string\",\"description\":\"Avai" +
            "lable to use for quota purposes for server-side applications. Can be any arbitra" +
            "ry string assigned to a user, but should not exceed 40 characters. Overrides use" +
            "rIp if both are provided.\",\"location\":\"query\"},\"userIp\":{\"type\":\"string\",\"descri" +
            "ption\":\"IP address of the site where the request originates. Use this if you wan" +
            "t to enforce per-user limits.\",\"location\":\"query\"}},\"schemas\":{\"Tokeninfo\":{\"id\"" +
            ":\"Tokeninfo\",\"type\":\"object\",\"properties\":{\"access_type\":{\"type\":\"string\",\"descr" +
            "iption\":\"The access type granted with this toke. It can be offline or online.\"}," +
            "\"audience\":{\"type\":\"string\",\"description\":\"Who is the intended audience for this" +
            " token. In general the same as issued_to.\"},\"email\":{\"type\":\"string\",\"descriptio" +
            "n\":\"The email address of the user. Present only if the email scope is present in" +
            " the request.\"},\"expires_in\":{\"type\":\"integer\",\"description\":\"The expiry time of" +
            " the token, as number of seconds left until expiry.\",\"format\":\"int32\"},\"issued_t" +
            "o\":{\"type\":\"string\",\"description\":\"To whom was the token issued to. In general t" +
            "he same as audience.\"},\"scope\":{\"type\":\"string\",\"description\":\"The space separat" +
            "ed list of scopes granted to this token.\"},\"user_id\":{\"type\":\"string\",\"descripti" +
            "on\":\"The Gaia obfuscated user id.\"},\"verified_email\":{\"type\":\"boolean\",\"descript" +
            "ion\":\"Boolean flag which is true if the email address is verified. Present only " +
            "if the email scope is present in the request.\"}}},\"Userinfo\":{\"id\":\"Userinfo\",\"t" +
            "ype\":\"object\",\"properties\":{\"birthday\":{\"type\":\"string\"},\"email\":{\"type\":\"string" +
            "\"},\"family_name\":{\"type\":\"string\"},\"gender\":{\"type\":\"string\"},\"given_name\":{\"typ" +
            "e\":\"string\"},\"id\":{\"type\":\"string\"},\"link\":{\"type\":\"string\"},\"locale\":{\"type\":\"s" +
            "tring\"},\"name\":{\"type\":\"string\"},\"picture\":{\"type\":\"string\"},\"timezone\":{\"type\":" +
            "\"string\"},\"verified_email\":{\"type\":\"boolean\"}}}},\"methods\":{\"tokeninfo\":{\"id\":\"o" +
            "auth2.tokeninfo\",\"path\":\"oauth2/v2/tokeninfo\",\"httpMethod\":\"POST\",\"parameters\":{" +
            "\"access_token\":{\"type\":\"string\",\"location\":\"query\"},\"id_token\":{\"type\":\"string\"," +
            "\"location\":\"query\"}},\"response\":{\"$ref\":\"Tokeninfo\"}}},\"resources\":{\"userinfo\":{" +
            "\"methods\":{\"get\":{\"id\":\"oauth2.userinfo.get\",\"path\":\"oauth2/v2/userinfo\",\"httpMe" +
            "thod\":\"GET\",\"response\":{\"$ref\":\"Userinfo\"}}},\"resources\":{\"v2\":{\"resources\":{\"me" +
            "\":{\"methods\":{\"get\":{\"id\":\"oauth2.userinfo.v2.me.get\",\"path\":\"userinfo/v2/me\",\"h" +
            "ttpMethod\":\"GET\",\"response\":{\"$ref\":\"Userinfo\"}}}}}}}}}}";
        
        public const string Version = "v2";
        
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string _Key;
        
        protected Oauth2Service(Google.Apis.Discovery.IService _service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this._service = _service;
            this._authenticator = _authenticator;
            this._userinfo = new UserinfoResource(this, _authenticator);
        }
        
        public Oauth2Service() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public Oauth2Service(Google.Apis.Authentication.IAuthenticator _authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(Oauth2Service.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameters(new System.Uri("https://www.googleapis.com/"))), _authenticator) {
        }
        
        public Google.Apis.Authentication.IAuthenticator Authenticator {
            get {
                return this._authenticator;
            }
        }
        
        public virtual string Name {
            get {
                return "oauth2";
            }
        }
        
        public virtual string BaseUri {
            get {
                return "https://www.googleapis.com/";
            }
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this._Key;
            }
            set {
                this._Key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this._service.CreateRequest(resource, method);
            if ((string.IsNullOrEmpty(Key) == false)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(_authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            _service.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return _service.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return _service.DeserializeResponse<T>(response);
        }
    }
    
    public class UserinfoResource {
        
        private Oauth2Service service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string Resource = "userinfo";
        
        private V2Resource _v2;
        
        public UserinfoResource(Oauth2Service service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this.service = service;
            this._authenticator = _authenticator;
            this._v2 = new V2Resource(service, _authenticator);
        }
        
        public virtual V2Resource V2 {
            get {
                return this._v2;
            }
        }
        
        public virtual GetRequest Get() {
            return new GetRequest(service);
        }
        
        public class V2Resource {
            
            private Oauth2Service service;
            
            private Google.Apis.Authentication.IAuthenticator _authenticator;
            
            private const string Resource = "userinfo.v2";
            
            private MeResource _me;
            
            public V2Resource(Oauth2Service service, Google.Apis.Authentication.IAuthenticator _authenticator) {
                this.service = service;
                this._authenticator = _authenticator;
                this._me = new MeResource(service, _authenticator);
            }
            
            public virtual MeResource Me {
                get {
                    return this._me;
                }
            }
            
            public class MeResource {
                
                private Oauth2Service service;
                
                private Google.Apis.Authentication.IAuthenticator _authenticator;
                
                private const string Resource = "userinfo.v2.me";
                
                public MeResource(Oauth2Service service, Google.Apis.Authentication.IAuthenticator _authenticator) {
                    this.service = service;
                    this._authenticator = _authenticator;
                }
                
                public virtual GetRequest Get() {
                    return new GetRequest(service);
                }
                
                public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Oauth2.v2.Data.Userinfo> {
                    
                    private string _oauth_token;
                    
                    private System.Nullable<bool> _prettyPrint;
                    
                    private string _quotaUser;
                    
                    public GetRequest(Google.Apis.Discovery.IRequestProvider service) : 
                            base(service) {
                    }
                    
                    /// <summary>OAuth 2.0 token for the current user.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Oauth_token {
                        get {
                            return this._oauth_token;
                        }
                        set {
                            this._oauth_token = value;
                        }
                    }
                    
                    /// <summary>Returns response with indentations and line breaks.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> PrettyPrint {
                        get {
                            return this._prettyPrint;
                        }
                        set {
                            this._prettyPrint = value;
                        }
                    }
                    
                    /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string QuotaUser {
                        get {
                            return this._quotaUser;
                        }
                        set {
                            this._quotaUser = value;
                        }
                    }
                    
                    protected override string ResourcePath {
                        get {
                            return "userinfo.v2.me";
                        }
                    }
                    
                    protected override string MethodName {
                        get {
                            return "get";
                        }
                    }
                }
            }
        }
        
        public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Oauth2.v2.Data.Userinfo> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "userinfo";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
    }
    
    public partial class Oauth2Service {
        
        private const string Resource = "";
        
        private UserinfoResource _userinfo;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual UserinfoResource Userinfo {
            get {
                return this._userinfo;
            }
        }
        
        public virtual TokeninfoRequest Tokeninfo() {
            return new TokeninfoRequest(service);
        }
        
        public class TokeninfoRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Oauth2.v2.Data.Tokeninfo> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private string _access_token;
            
            private string _id_token;
            
            public TokeninfoRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Access_token {
                get {
                    return this._access_token;
                }
                set {
                    this._access_token = value;
                }
            }
            
            [Google.Apis.Util.RequestParameterAttribute("id_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id_token {
                get {
                    return this._id_token;
                }
                set {
                    this._id_token = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "";
                }
            }
            
            protected override string MethodName {
                get {
                    return "tokeninfo";
                }
            }
        }
    }
}
