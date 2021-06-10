# Live Query API

<p>REST API for Live Query Web App.</p>
<p>C# web service built using Microsoft ASP.NET Core and documented on Swagger UI.</p>
<p><b>Link to API:</b> https://livequeryapi.azurewebsites.net</p>

<h2>Documentation</h2>
  
<h3><u>Questions endpoints</u></h3>
<br>

Get all questions.

```
GET: /api/Questions
```

Post a question.

```
POST: /api/Questions
```

Get single question.

```
GET: /api/Questions/{id}
```

Update a question.

```
PUT: /api​/Questions​/{id}
```

Delete a question.

```
DELETE: /api/Questions/{id}
```

<h3><u>Comments endpoints</u></h3>
<br>

Get all comments.

```
GET: /api​/Comments
```

Post a comment.

```
POST: /api/Comments
```

Get single comment.

```
GET: ​/api​/Comments​/{id}
```

Update a comment.

```
PUT: /api/Comments/{id}
```

Delete a comment.

```
DELETE: /api/Comments/{id}
```

<h3><u>Database schema</u></h3>
<br>

Questions - one to many relationship - Comments

```
Questions{
	questionID* - integer($int32)
	firstName* - string
	lastName* - string
	question* - string
	description* - string
	data [
		nullable:  true
		Comments{
			commentID* - integer($int32)
			name* - string
			comment* - string
			questionID* - integer($int32)
			}]
}

* NOT NULLABLE
```
