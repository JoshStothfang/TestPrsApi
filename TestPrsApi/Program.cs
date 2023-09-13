using System.Text.Json;
using TestPrsApi;

const string baseUrl = "http://localhost:5555";

JsonSerializerOptions jsonOptions = new JsonSerializerOptions()
{
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    WriteIndented = true
};

HttpClient _http = new HttpClient();

/*
#region GetAll
var jsonresponse = await GetUsersAsync(_http, jsonOptions);
var users = (IEnumerable<User>)jsonresponse.DataReturned!;
//var users = jsonresponse.DataReturned as IEnumerable<User>; //Newer syntax for the line above

foreach(var user in users)
{
    Console.WriteLine($"{user.Firstname} {user.Lastname}");
}


async Task<JsonResponse> GetUsersAsync(HttpClient http, JsonSerializerOptions jsonOptions)
{
    HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/api/Users");
    HttpResponseMessage res = await http.SendAsync(req);
    Console.WriteLine($"Http ErrorCode is {res.StatusCode}");
    if(res.StatusCode != System.Net.HttpStatusCode.OK)
    {
    }
    var json = await res.Content.ReadAsStringAsync();
    var users = (IEnumerable<User>?)JsonSerializer.Deserialize(json, typeof(IEnumerable<User>), jsonOptions);
    if (users == null)
    {
        throw new Exception();
    }
    return new JsonResponse()
    {
        HttpStatusCode = (int)res.StatusCode,
        DataReturned = users
    };
}
#endregion
*/

/*
var jsonresponse2 = await GetUserAsync(2, _http, jsonOptions);
var user2 = (User)jsonresponse2.DataReturned!;

Console.WriteLine($"{user2.Firstname} {user2.Lastname}");

async Task<JsonResponse> GetUserAsync(int id, HttpClient http, JsonSerializerOptions jsonOptions)
{
    HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/api/Users/{id}");
    HttpResponseMessage res = await http.SendAsync(req);
    Console.WriteLine($"Http ErrorCode is {res.StatusCode}");
    if (res.StatusCode != System.Net.HttpStatusCode.OK)
    {
    }
    var json = await res.Content.ReadAsStringAsync();
    var user = (User?)JsonSerializer.Deserialize(json, typeof(User), jsonOptions);
    if (user == null)
    {
        throw new Exception();
    }
    return new JsonResponse()
    {
        HttpStatusCode = (int)res.StatusCode,
        DataReturned = user
    };
}
*/

/*
var user1 = new User()
{
    Id = 1,
    Username = "Administrator",
    Password = "PinkUnicorn123",
    Firstname = "John",
    Lastname = "Doe",
    Phone = "837-689-9384",
    Email = "jdoe@prs.com",
    IsReviewer = false,
    IsAdmin = true
};

await UpdateUser(user1, jsonOptions);

async Task<JsonResponse> UpdateUser(User user, JsonSerializerOptions jsonOptions)
{
    HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Put, $"{baseUrl}/api/Users/{user.Id}");
    var json = JsonSerializer.Serialize<User>(user, jsonOptions);
    req.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
    HttpResponseMessage res = await _http.SendAsync(req);
    Console.WriteLine($"Http StatusCode is {res.StatusCode}");
    return new JsonResponse()
    {
        HttpStatusCode = (int)res.StatusCode
    };

}
*/

/*
var newUser = new User()
{
    Id = 0,
    Username = "TestUser",
    Password = "TestPassword123",
    Firstname = "Jane",
    Lastname = "Doe",
    Phone = "837-689-9384",
    Email = "jdoe@prs.com",
    IsReviewer = false,
    IsAdmin = false
};

await AddUser(newUser, jsonOptions);

async Task<JsonResponse> AddUser(User user, JsonSerializerOptions jsonOptions)
{
    HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, $"{baseUrl}/api/Users");
    var json = JsonSerializer.Serialize<User>(user, jsonOptions);
    req.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
    HttpResponseMessage res = await _http.SendAsync(req);
    Console.WriteLine($"Http StatusCode is {res.StatusCode}");
    return new JsonResponse()
    {
        HttpStatusCode = (int)res.StatusCode
    };
}
*/

await DeleteUser(4, jsonOptions);

async Task<JsonResponse> DeleteUser(int id, JsonSerializerOptions jsonOptions)
{
    HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Delete, $"{baseUrl}/api/Users/{id}");
    HttpResponseMessage res = await _http.SendAsync(req);
    Console.WriteLine($"Http StatusCode is {res.StatusCode}");
    return new JsonResponse()
    {
        HttpStatusCode = (int)res.StatusCode
    };
}