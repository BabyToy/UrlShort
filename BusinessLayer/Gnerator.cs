using DataLayer;
using System;
using System.Linq;

namespace BusinessLayer
{
    public class Generator
    {
        private ShortContext context;

        public Generator(ShortContext context)
        {
            this.context = context;
        }

        public string NewSegment()
        {
            int idx = 0;
            while (idx < 30)
            {
                var guid = Guid.NewGuid();
                var segment = guid.ToString().Substring(0, 8);
                if (!context.ShortUrls.Where(x => x.Segment == segment).Any())
                {
                    return segment;
                }
                idx++;
            }
            return string.Empty;
        }
    }
}