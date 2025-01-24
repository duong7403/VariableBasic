using System;

namespace VariableBasic.Service;

public class StudentManager
{
    private readonly List<Student> _student;

    public StudentManager(){
        _student = new List<Student>();
    }

}
