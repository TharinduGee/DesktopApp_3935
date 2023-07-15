using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp_3935 {
    public partial class AddController : ObservableObject {
        public ObservableCollection<Student> Students { get; set; }

        public AddController(ObservableCollection<Student> students) {
            Students = students;
        }
    }
}
