using System;
namespace API_with_ODBC.Request
{
    public class PostRequest
    {
        public string Title { get; set; }

        public string Text { get; set; }

        public int AuthorID { get; set; }
    }
}
