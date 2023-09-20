# Shapes


Библиотека классов геометрических фигур. Включает круг и треугольник.

* Классы круга и треугольника наследуются от абстрактного класса "Shape", который содержит свойство Area.
* Можно либо создавать объекты круга / треугольника, либо использовать статические методы их классов.
* Класс "Circle" содержит свойства Radius и Area (унаследованное от Shape), а также статический метод CalculateArea, который принимает положительное double число radius как аргумент. Отрицательный радиус выбрасывает ошибку.
* Класс "Triangle" содержит свойства Sides, Area (унаследованное от Shape) и IsRight, и статические методы CalculateArea и CheckIfRight, оба принимают три положительных double числа, соответствущие сторонам треугольника. Отрицательные числа выбрасывают ошибку.
* Методы треугольника также проверяют, могут ли данные три стороны сформировать треугольник.  
* ToString у обоих классов переопределён.
* Юнит-тесты обоих классов прилагаются.
  
____________
Class library for geometric shapes. Currently provides circle and triangle.

* Both classes are inherited from an abstract class "Shape" with Area property.
* You can either create instances or use static methods.
* "Circle" class has Radius and Area properties, and a static method CalculateArea that accepts a positive double. Passing negative radius throws an argument exception
* "Triangle" class has Sides, Area and IsRight properties, and static methods CalculateArea and CheckIfRight, both accept three positive double numbers correlating to triangle's sides. Passing negative sides throw an argument exception.
* Triangle's methods also check if given three sides can form a triangle.  
* ToString is overriden for both classes.
* Unit tests for both classes are included.
