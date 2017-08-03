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
        // public int SmallCols { get; set; }

        // public int MedCols { get; set; }

        // public int LargeCols { get; set; }

        public int Cols { get; set; }

        public Cell(params BodyElement[] content) : base(content)
        {
            AddClass("col");            
        }

        public Cell(int cols, params BodyElement[] content) : base(content)
        {
            Cols = cols;

            AddClass("col-" + cols);            
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

        public static Cell Cell(params BodyElement[] content)
        {
            return new Cell(content);
        }

        public static Cell Cell(int cols, params BodyElement[] content)
        {
            return new Cell(cols, content);
        }
    }
}