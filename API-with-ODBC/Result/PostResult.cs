using System;
namespace API_with_ODBC.Result
{
    public class PostResult
    {
        public int PostID { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime Created { get; set; }

        public int AuthorID { get; set; }
    }
}
