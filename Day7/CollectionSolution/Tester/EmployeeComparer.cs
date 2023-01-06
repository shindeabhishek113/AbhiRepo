namespace TFLCollection;
class EmpComparer:IComparer<Employee>{
    public int Compare(Employee e1, Employee e2){
        Console.WriteLine("in comper to");
        // int ret = e1.salary.CompareTo(e2.salary);
        // return ret;

        int ret1 = e1.id.CompareTo(e2.id);
        return ret1;
        // if(e1.salary > e2.salary){
        //     return 1;
        // }
        // else if (e1.salary < e2.salary){
        //     return -1;
        // }
        // else
        // return 0;



}

}