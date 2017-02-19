using Android.App;
using Android.Widget;
using Android.OS;

namespace ListViewAndroidXamarin
{
    [Activity(Label = "ListViewAndroidXamarin", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            EmployeeList employeeList = new EmployeeList();
            var employees = employeeList.GetEmployees(20);

            ListView lvEmployees = FindViewById<ListView>(Resource.Id.lvEmployees);
            
            //Line bellow used just to test random listview
            //ArrayAdapter<Employee> adapter = new ArrayAdapter<Employee>(this, Android.Resource.Layout.SimpleListItem1, employees);
            
            //Line bellow returns random data with Name and Email properties
            EmployeeAdapter adapter = new EmployeeAdapter(employees);

            lvEmployees.Adapter = adapter;
        }
    }
}

