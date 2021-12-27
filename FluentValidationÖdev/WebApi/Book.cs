using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi {   //namespace belirttim.


public class Book{  //book adında bir sınıf oluşturdum.

[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int Id {get;set;}  //getter ve setterlarını oluşturdum,bir properties oluşturdum.

public string Title { get; set; }  //Kitabın başlık adında özelliğini(properties) oluşturdum.

public int GenreId { get; set; }  //Kitabın türün adındaki özelliği(properties) tanımladım.

public int PageCount {get; set;} //Kitabın sayfa sayısı adında bir özelliğini(properties) tanımladım ve getter ve setterını ayarladım.

public DateTime  PublishDate {get ; set;}  //Türü DateTime olan bir özelliği(properties) tanımladım.

}
}