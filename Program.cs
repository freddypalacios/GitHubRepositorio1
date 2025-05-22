using System.Collections;
//defincion e inicialización de los arreglos en paralelo y el diccionario
String[] Departamento = { "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", "Costa Caribe Sur", "Estelf", "Granada", "Jinotega", "León", "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", "Rio San、Juan", "Rivas" };
int[] Poblacion = { 185013, 197139, 439906, 190863, 530586, 414543, 229866, 214317, 475630, 421050, 174744,  1575819, 391903, 593503, 271581, 135446, 182645 };

Diccionario d=new Diccionario(Departamento,Poblacion);
d.Operaciones(Departamento, Poblacion); 
