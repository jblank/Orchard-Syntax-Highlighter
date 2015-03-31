using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Blogs.Models;
using TheMonarch.SyntaxHighlighter.Models;

namespace TheMonarch.SyntaxHighlighter.Handlers {
    public class SyntaxHighlighterPartHandler : ContentHandler {
        public SyntaxHighlighterPartHandler() {
            Filters.Add(new ActivatingFilter<SyntaxHighlighterPart>("BlogPost"));
        }
    }
}
