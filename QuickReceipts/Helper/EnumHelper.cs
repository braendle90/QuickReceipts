using Microsoft.AspNetCore.Mvc.Rendering;

namespace QuickReceipts.Helper
{
    public static class EnumHelper
    {
        public static SelectList ToSelectList<TEnum>() where TEnum : struct
        {
            var items = from enumValue in Enum.GetValues(typeof(TEnum)).Cast<TEnum>()
                        select new
                        {
                            ID = Convert.ToInt32(enumValue),
                            Name = enumValue.ToString()
                        };

            return new SelectList(items, "ID", "Name");
        }
    }
}
