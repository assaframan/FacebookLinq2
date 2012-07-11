﻿
namespace CreateTableClassesFromFacebookPages
{
    using System;
	using System.Dynamic;
	using System.Windows.Forms;
    using Facebook;

    public partial class FacebookLoginDialog : Form
    {
        private readonly Uri _loginUrl;
        protected FacebookClient _fb;

        public FacebookOAuthResult FacebookOAuthResult { get; private set; }

        public FacebookLoginDialog(string appId, string extendedPermissions)
            : this(new FacebookClient(), appId, extendedPermissions)
        {
        }

        public FacebookLoginDialog(FacebookClient fb, string appId, string extendedPermissions)
        {
            if (fb == null)
                throw new ArgumentNullException("fb");
			if ((appId == null || appId == ""))
                throw new ArgumentNullException("appId");

            _fb = fb;
            _loginUrl = GenerateLoginUrl(appId, extendedPermissions);

            InitializeComponent();
        }

        private Uri GenerateLoginUrl(string appId, string extendedPermissions)
        {
            dynamic parameters = new ExpandoObject();
            parameters.client_id = appId;
            parameters.redirect_uri = "https://www.facebook.com/connect/login_success.html";

            // The requested response: an access token (token), an authorization code (code), or both (code token).
            parameters.response_type = "token";

            // list of additional display modes can be found at http://developers.facebook.com/docs/reference/dialogs/#display
            parameters.display = "popup";

            // add the 'scope' parameter only if we have extendedPermissions.
            if (!string.IsNullOrWhiteSpace(extendedPermissions))
                parameters.scope = extendedPermissions;

            // when the Form is loaded navigate to the login url.
            return _fb.GetLoginUrl(parameters);
        }

        private void FacebookLoginDialog_Load(object sender, EventArgs e)
        {
            // make sure to use AbsoluteUri.
            webBrowser1.Navigate(_loginUrl.AbsoluteUri);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // whenever the browser navigates to a new url, try parsing the url.
            // the url may be the result of OAuth 2.0 authentication.

            FacebookOAuthResult oauthResult;
            if (_fb.TryParseOAuthCallbackUrl(e.Url, out oauthResult))
            {
                // The url is the result of OAuth 2.0 authentication
                FacebookOAuthResult = oauthResult;
                DialogResult = FacebookOAuthResult.IsSuccess ? DialogResult.OK : DialogResult.No;
            }
            else
            {
                // The url is NOT the result of OAuth 2.0 authentication.
                FacebookOAuthResult = null;
            }
        }
    }
}
