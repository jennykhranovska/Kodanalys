Vad du har hittat f�r problem

Otydliga och konstiga variabelnamn

Brist p� metodindelning. All logik ligger i Main metoden, vilket g�r den l�ng och sv�r�versk�dlig.

Menyn skrivs ut om och om igen utan att rensa konsolen, vilket g�r anv�ndargr�nssnittet r�rigt

Ingen bekr�ftelse vid borttagning

Vid visning av anv�ndare om listan �r tom, visas bara rubriken "Anv�ndare:" men ingen information om att listan �r tom.


Vad du har f�rb�ttrat

I koden har jag bytt namn p� vissa variabler f�r att g�ra dem mer beskrivande och l�tta att f�rst�:

celestialWhispers har bytts till userNames f�r att tydligt visa att det �r en array som lagrar anv�ndarnamn.

magicConstant �ndrade till userCount som �r r�knare f�r hur m�nga anv�ndarnamn som sparats.

Det h�r g�r koden mer sj�lvdokumenterande och underl�ttar b�de l�sning och underh�ll.

Variabeln entitetsExcisionIdentifierare har �ndrats till nameToRemove f�r att g�ra koden mer l�ttl�st och tydlig.


Jag har refaktorerat programmet genom att ers�tta if-satser med en switch sats f�r att hantera menyalternativen.

Detta g�r koden mer l�sbar och l�ttare att underh�lla.

Varje menyval hanteras nu i en egen metod i en separat klass UserMenu, vilket f�rb�ttrar struktur och modularitet i programmet.

Har lagt till funktioner s� att n�r anv�ndare visas och listan �r det inte tom, nu visas  meddelandet

"Inga anv�ndare hittades." �ven bekr�ftelse vid borttagning s� det kommer fram att anv�ndaren har tagit bort.

Menyn visas tydligt och konsolen rensas mellan varje val f�r att ge en ren och l�ttl�st upplevelse.

Efter varje val f�r anv�ndaren ett meddelande och trycker p� en tangent f�r att forts�tta.

Vad du har l�rt dig

Genom att analysera och refaktorera den befintliga koden har jag l�rt mig hur viktigt det �r med bra variabelnamnoch

tydlig struktur. Sm� f�r�ndringar, som att rensa konsolen kan g�ra stor skillnad f�r upplevelsen.

Jag har ocks� insett hur mycket l�ttare det �r att f�rst� och underh�lla kod n�r den �r uppdelad i mindre, 

tydliga metoder. Det g�r det enklare att fels�ka, �teranv�nda och bygga ut funktioner i framtiden.

Dessutom har jag l�rt mig hur jag kan anv�nda Git och commits f�r att dokumentera mina f�rb�ttringar steg f�r steg.




