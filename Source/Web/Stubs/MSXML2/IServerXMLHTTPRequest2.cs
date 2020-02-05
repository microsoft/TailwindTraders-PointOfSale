namespace Stub._MSXML2
{

   public interface IServerXMLHTTPRequest2
   {

      void open(string bstrMethod, string bstrUrl, object
         varAsync = default(object), object bstrUser =
         default(object), object bstrPassword = default(object));

      void send(object varBody = default(object));

      int status { get; }

      string responseText { get; }

   }

}