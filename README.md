# Инструкция по установке
1. Открыть CardLibrary\MyLibrary.xml в "Docsvision CardManager" и загрузить в нужную БД.
2. В "Docsvision CardManager" щелкнуть ПКМ по нужной БД и выбрать "Load Library To Database"
3. Создать новый веб-сайт в IIS и скопировать содержимое папки WebApplication в папку веб-сайта.
4. С помощью  Postman отправить запрос по адресу /api/card/create

Пример тела запроса:
<pre>{
docKind: "docKind",
docNumber: "docNumber",
creationDate: "2012-04-23",
mainAccount: "1",
correspondentAccount: "2",
partnerCode: "code",
orderNumber: "00000005",
extraInfo: "extraInfo",
warehouse: "10",
shortContent: "shortContent",
providingNumber: "providingNumber",
loadDate: "2012-04-23T18:25:43.511Z"
}</pre>
Возвращаемое значение: Идентификатор карточки

Заголовок авторизации должнен состоять из адреса подключения к StorageServerService.asmx, логина и пароля через пробел, с префиксом DV

<pre>DV aHR0cDovL2R2c2hvd2Nhc2UvRG9jc3Zpc2lvbi9TdG9yYWdlU2VydmVyL1N0b3JhZ2VTZXJ2ZXJTZXJ2aWNlLmFzbXggYWRtaW5pc3RyYXRvciBwYXNzd29yZA==</pre>