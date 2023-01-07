# UnitOfWork_Design_Pattern
Unit Of Work tasarım deseni, yazılım uygulamamızda veritabanıyla ilgili her bir aksiyonun anlık olarak veritabanına yansıtılmasını engelleyen
ve buna nazaran tüm aksiyonları biriktirip bir bütün olarak bir defada tek bir connection üzerinden gerçekleştirilmesini sağlayan 
ve böylece veritabanı maliyetlerini oldukça minimize eden bir tasarım desenidir.
Transaction yani veri tabanı işlemlerinde veri kaybını önlemek için kullanılır. 
