using static HtmlHelper.Helpers;

namespace HtmlHelper.Bootstrap
{
    public enum BadgeType
    {
        Default, 
        Primary,
        Success,
        Info,
        Warning,
        Danger
    }

    public class Badge : Span
    {
        public BadgeType Type { get; }

        public Badge(BadgeType type, params BodyElement[] content) : base(content)
        {
            Type = type;
            AddClass("badge");
            AddClass("badge-" + type.ToString().ToLower());
        }
    }

    public class PillBadge : Badge
    {
        public PillBadge(BadgeType type, params BodyElement[] content) : base(type, content)
        {
            AddClass("badge-pill");
        }
    }

    public static partial class Helpers
    {
        public static Badge Badge(BadgeType type, params BodyElement[] content)
        {
            return new Badge(type, content);
        }

        public static Badge Badge(params BodyElement[] content)
        {
            return new Badge(BadgeType.Default, content);
        }

        public static PillBadge PillBadge(BadgeType type, params BodyElement[] content)
        {
            return new PillBadge(type, content);
        }

        public static PillBadge PillBadge(params BodyElement[] content)
        {
            return new PillBadge(BadgeType.Default, content);
        }
    }
}