using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using System.Collections.Generic;

namespace RadzenBlazorDemos;

static class RadzenExtensions
{
    public static void OpenContextMenu(this ContextMenuService src, MouseEventArgs args, IEnumerable<ContextMenuItem> items)
    {
        src.Open(args, items, menuItemEventArgs =>
        {
            EventCallback<MenuItemEventArgs> callback = (EventCallback<MenuItemEventArgs>)menuItemEventArgs.Value;
            callback.InvokeAsync();
        });
    }
}
