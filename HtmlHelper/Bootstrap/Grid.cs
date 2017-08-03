namespace HtmlHelper.Bootstrap
{
    public class Grid : Container
    {
        public Grid(params Row[] rows) : base(rows)
        {
        }
    }

    public class FluidGrid : FluidContainer
    {
        public FluidGrid(params Row[] rows) : base(rows)
        {
        }
    }

    public class Row : Div
    {
        public Row(params Cell[] cells) : base(cells)
        {
            AddClass("row");
        }
    }

    public class Cell : Div
    {
        public int SmallCols { get; set; }

        public int MedCols { get; set; }

        public int LargeCols { get; set;}

        public Cell(int smallCols, params BodyElement[] content) : base(content)
        {
            SmallCols = smallCols;

            AddClass("col-sm-" + smallCols);            
        }
    }

    public static partial class Helpers
    {
        public static Grid Grid(params Row[] rows)
        {
            return new Grid(rows);
        }

        public static FluidGrid FluidGrid(params Row[] rows)
        {
            return new FluidGrid(rows);
        }

        public static Row Row(params Cell[] cells)
        {
            return new Row(cells);
        }

        public static Cell Cell(int smallCols, params BodyElement[] content)
        {
            return new Cell(smallCols, content);
        }
    }
}