using System.Collections.Specialized;
using System.Web;


namespace PhotoSharingTests.Doubles {

	public class FakeHttpContextForRouting : HttpContextBase
    {
        FakeHttpRequestForRouting _request;
        FakeHttpResponseForRouting _response;

        public FakeHttpContextForRouting(string appPath = "/", string requestUrl = "~/")
        {
            _request = new FakeHttpRequestForRouting(appPath, requestUrl);
            _response = new FakeHttpResponseForRouting();
        }

        public override HttpRequestBase Request => _request;

	    public override HttpResponseBase Response => _response;
    }

    public class FakeHttpRequestForRouting : HttpRequestBase
    {
	    public FakeHttpRequestForRouting(string appPath, string requestUrl)
        {
            ApplicationPath = appPath;
            AppRelativeCurrentExecutionFilePath = requestUrl;
        }

        public override string ApplicationPath { get; }

	    public override string AppRelativeCurrentExecutionFilePath { get; }

	    public override string PathInfo => "";

	    public override NameValueCollection ServerVariables => new NameValueCollection();
    }

    public class FakeHttpResponseForRouting : HttpResponseBase
    {
        public override string ApplyAppPathModifier(string virtualPath)
        {
            return virtualPath;
        }
    }


}
