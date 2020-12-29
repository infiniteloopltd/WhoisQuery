# WhoisQuery

When you register a domain name, your details are kept in a Whois file with your registrar, which is then accessible via a Whois query.

What is interesting is that the format of the response of Whois is very unstandardized, and varies both in form and content from country to country. I checked this with a few of my own domains, to see the difference in the raw response;

Ireland:

https://github.com/infiniteloopltd/WhoisQuery/blob/master/ie-tld.txt

Mostly redacted, the organisation name was visible though.

Island

https://github.com/infiniteloopltd/WhoisQuery/blob/master/is-tld.txt

The details of the registrar were available, but just a handle for the registrant.

Italy

https://github.com/infiniteloopltd/WhoisQuery/blob/master/it-tld.txt

The registrant was visible, perhaps because it is a company, not a natural person.

Latvia

https://github.com/infiniteloopltd/WhoisQuery/blob/master/lv-tld.txt

No registrant detail available.

Ukraine

https://github.com/infiniteloopltd/WhoisQuery/blob/master/ua-tld.txt

The details of the registrar were available, but just a handle for the registrant. Text in Cyrillic (UTF8)

UK

https://github.com/infiniteloopltd/WhoisQuery/blob/master/uk-tld.txt

Minimal details of the registrar were available.

Israel

Omitted because of personal data availability

This was the only TLD that disclosed actual personal details, including a full name, and address.

The TLDs .com.cy (Cyprus) and .com.my (Malaysia) didn’t seem to work, when I tried.
