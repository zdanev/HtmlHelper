namespace HtmlHelper
{
    public class Table : BodyElement
    {
        public Table(params TableRow[] rows) : base("table", rows)
        {           
        }
    }

    public class TableRow : BodyElement
    {
        public TableRow(params TableCell[] cells) : base("tr", cells)
        {
        }
    }

    public class TableCell : BodyElement
    {
        public TableCell(params BodyElement[] content) : base("td", content)
        {
        }
    }

    public static partial class FluentApi
    {
        public static Table Table(params TableRow[] rows)
        {
            return new Table(rows);
        }

        public static TableRow TR(params TableCell[] cells)
        {
            return new TableRow(cells);
        }

        public static TableCell TD(params BodyElement[] content)
        {
            return new TableCell(content);
        }
    }
}