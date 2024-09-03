using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Test
{
    public class DateHelperTest
    {
        

        [Test]
        public void check_valid_date()
        {
            var dd = DateTime.Now;
            var expected = new DateTime(dd.Year, dd.Month + 1, 1);
            var date = DateHelper.FirstOfNextMonth(dd);
            Assert.AreEqual(expected, date);
            

        }
        

    }
}
