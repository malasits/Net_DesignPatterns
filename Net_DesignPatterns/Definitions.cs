using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_DesignPatterns
{
    class Definitions
    {
        //----------------KULCSSZAVAK ÉS DEFINÍCIÓK---------------------------------------------------------------------------------------------------------------------------------------------------

        /*
         változó delkarációk:
            -private            -> csak a tartalmazó osztályban lehet hozzáférni
            -public             -> nincs korlátozás
            -protected          -> csak a tartalmazó osztályból és a származtatott osztályokban lehet használni
            -internal           -> csak a tartalmazó programból lehet használni
            -protected internal -> ua. mint előbb plusz a protected hozzáférés

         metódus paraméter átadások:
            -Érték szerinti      -> módosító használata nélkül, primitív típusok esetén
            -Referencia szerinti -> ref módosítóval vagy referencia típusok esetén
            -Out paraméter       -> out módosítóval, nem jön létre helyfoglalás, hasonlóan a referencia szerinti paraméterhez
            -Tömb paraméter      -> mivel minden object, ezért egy object tömbben bármilyen típust átadhatunk

         override:
            -Virtuális metódusok esetén az override kulcsszó segítségével kell jeleznünk, hogy az ősosztály virtuális metódusát szeretnénk specializálni

         base:
            -A közvetlen ősosztályra a base kulcsszóval hivatkozhatunk
 
         sealed:
            -A sealed kulcsszó használatával megakadályozhatjuk, hogy egy osztályból származtassanak vagy egy metódust felüldefiniáljon a származtatott osztály
            -Ha egy metódusnál a sealed override hozzáférést használjuk, akkor ezzel meggátoljuk, hogy egy származtatott osztályban felülírjuk ezt a metódust

        extern:
            -Az external módosítóval rendelkező metódusok valamilyen más nyelven vannak implementálva
            -Éppen ezért a metódus törzsében csak egy pontosvessző áll
            -Az ilyen metódus nem lehet abstract
            -pl.:[  [DllImport("avifil32.dll")]                 ]
                 [  private static extern void AVIFileInit();]  ]

         abstract:
            -Az abstract kulcsszó használatával azt jelezhetjük, hogy az adott osztály még nincs teljesen megvalósítva.
            -Absztrakt osztály emiatt nem példányosítható, csak ősosztály lehet
            -Az absztraktként definiált metódusait a származtatott osztályban meg kell valósítani
            -Természetesen egy absztrakt osztály nem lehet sealed (véglegesített)
            -Annak ellenére, hogy egy absztrakt metódus tulajdonképpen virtuális, nem használhatjuk a virtual megjelölést
            -Természetesen static -ként sem lehet definiálni az absztrakt metódusokat
            -Ezeket a metódusokat a származtatott osztályokban implementálhatjuk úgy, hogy az adott metódushoz megírjuk a törzs részt is
         */

    }
}
