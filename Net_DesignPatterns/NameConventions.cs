using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_DesignPatterns
{
    class NameConventions
    {
        //1. -Használj PascalCase -t osztálynevek és metódusnevek deklarálásához
        //2. -Használj camelCase -t metódus paraméterek és metódus változók deklarálásához
        //3. -Ne használj magyar jelölést vagy bármilyen más típusú azonosítást az azonosítókban
        //4. -Ne használj CAPS-LOCK ot readonly és constans változóknál
        //5. -Kerüld a rövidítéseket, kivéve => a gyakran használt azonosítók esetén (pl.: Id, Xml, Ftp, Uri)
        //6. -Használj PascalCase-t 3 vagy több rövídítések esetén (pl.: HtmlHelper, FtpTransfer )
        //   -  2karakteres rövidítés esetén mindegyiknagybetű (pl.: UIControl )
        //7. -Ne használj aláhúzást változónevekben
        //   -  Kivéve, ha privát, vagy statikus változót azonosítunk vele (pl.: private _variableIdentifier)
        //8. -Használj előre definiált típusneveket (byte, string) rendszer típusok helyett(Int16, Single)
        //9. -Használj implicit típust (var), helyi változók deklarálása esetén (pl.: var variable = File.Create(path))
        //   -  Kivéve primitív típusoknál(pl.:int, string)
        //10.-Használj főneveket osztálynevek esetén
        //11.-Használj 'I' előtagot interfészek elnevezésében
        //   -  Az interfésznevek főnevek, vagy melléknevek
        //12.-A fájlnevek legyenek azonosak a bennük létrehozott osztály nevével
        //   -Kivéve a partial típusú osztályoknál, ebben az esetben a fájl neve utaljon az osztály funkciójára
        //13.-A névterek összekapcsolása egyértelműen meghatározott struktúrával történik (pl.: Company.Product.Module.SubModule)
        //14.-Függőlegesen igazítsuk a kapcsos zárójeleket
        //15.-A tagváltozókat az osztály leglején deklaráljuk
        //   -A statikus változók legyenek legfelül
        //16.-Használj egytagú neveket enumokra
        //   -Kivéve bit mezős enumok
        //17.-Ne adj típust az enumoknak, mert zavart okozhat a működésben, ha tényleges típusokra és értékeket támaszkodik (pl.: public enum Direction : long)
        //18.-Ne egészítsd ki az enum nevét + "Enum" -al (pl.: colorsEnum)
    }
}
