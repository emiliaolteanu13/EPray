using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPray.Models
{
    public class PrayerModel
    {
        public int Id { get; set; }
        public string Lyrics { get; set; }
        public ReligionType Religion { get; set; }
        public PrayerReasonType Reason { get; set; }
        public string Target { get; set; }
    }
}
