# Shapes


Class library for geometric shapes. Currently provides circle and triangle.

* You can either create objects or use static methods.
* "Circle" class has Radius and Area properties, and a static method CalculateArea that accepts a positive double. Passing negative radius throws an argument exception
* "Triangle" class has Sides, Area and IsRight properties, and static methods CalculateArea and CheckIfRight, both accept three positive double numbers correlating to triangle's sides. Passing negative sides throw an argument exception.
* Triangle's methods also check if given three sides can form a triangle.  
* ToString is overriden for both classes.
* Unit tests for both classes are included.
