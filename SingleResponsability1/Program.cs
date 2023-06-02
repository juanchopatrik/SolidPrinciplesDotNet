using SingleResponsability;

StudentRepository studentRepository = new();
<<<<<<< Updated upstream
ExportHelper exportHelper = new();
exportHelper.ExportStudents(studentRepository.GetAll());
=======
ExportHelper exportHelper = new ExportHelper();

exportHelper.ExportStudent(studentRepository.GetAll());

>>>>>>> Stashed changes
Console.WriteLine("Proceso Completado");