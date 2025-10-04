Vad du har hittat för problem

Otydliga och konstiga variabelnamn

Brist på metodindelning. All logik ligger i Main metoden, vilket gör den lång och svåröverskådlig.

Menyn skrivs ut om och om igen utan att rensa konsolen, vilket gör användargränssnittet rörigt

Ingen bekräftelse vid borttagning

Vid visning av användare om listan är tom, visas bara rubriken "Användare:" men ingen information om att listan är tom.


Vad du har förbättrat

I koden har jag bytt namn på vissa variabler för att göra dem mer beskrivande och lätta att förstå:

celestialWhispers har bytts till userNames för att tydligt visa att det är en array som lagrar användarnamn.

magicConstant ändrade till userCount som är räknare för hur många användarnamn som sparats.

Det här gör koden mer självdokumenterande och underlättar både läsning och underhåll.

Variabeln entitetsExcisionIdentifierare har ändrats till nameToRemove för att göra koden mer lättläst och tydlig.


Jag har refaktorerat programmet genom att ersätta if-satser med en switch sats för att hantera menyalternativen.

Detta gör koden mer läsbar och lättare att underhålla.

Varje menyval hanteras nu i en egen metod i en separat klass UserMenu, vilket förbättrar struktur och modularitet i programmet.

Har lagt till funktioner så att när användare visas och listan är det inte tom, nu visas  meddelandet

"Inga användare hittades." Även bekräftelse vid borttagning så det kommer fram att användaren har tagit bort.

Menyn visas tydligt och konsolen rensas mellan varje val för att ge en ren och lättläst upplevelse.

Efter varje val får användaren ett meddelande och trycker på en tangent för att fortsätta.

Vad du har lärt dig

Genom att analysera och refaktorera den befintliga koden har jag lärt mig hur viktigt det är med bra variabelnamnoch

tydlig struktur. Små förändringar, som att rensa konsolen kan göra stor skillnad för upplevelsen.

Jag har också insett hur mycket lättare det är att förstå och underhålla kod när den är uppdelad i mindre, 

tydliga metoder. Det gör det enklare att felsöka, återanvända och bygga ut funktioner i framtiden.

Dessutom har jag lärt mig hur jag kan använda Git och commits för att dokumentera mina förbättringar steg för steg.




