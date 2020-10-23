using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

public class Methods
{

    private static readonly HttpClient client = new HttpClient();
    public async void Test()
    {
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "BQCBcW0ZHStG0fj_-eMdDMZTyQYC0PRHmFk7DEFm5c_QVoU90UHRgZpPvVv_kmAhfz7AdmN7AjWDTzbGkbQBLTLWfaK4ftXckWTNAyMT1W2j3OvMSpohYoyyt1NM67JJwaF6_TyCVVYDXQZqa5RoO2IpVuHneQ13Y7RqH_8KY5Zm9YiexU10k8oaXILzhG_tGzt2Nzrb9GQ-UptuJNxWAoWPyDjFMb_Q9CrMRVzMzPTA2oQ_nuzMDtmY8_Z1EsODX92yLKUmX0WNdagV6vU");
        client.DefaultRequestHeaders.Add("Accept", "application/json");
        //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
        var values = new Dictionary<string, string>
        {
            { "Accept", "application/json" },
            { "Content-Type", "application/json" },
            { "Authorization", "Bearer, BQCBcW0ZHStG0fj_-eMdDMZTyQYC0PRHmFk7DEFm5c_QVoU90UHRgZpPvVv_kmAhfz7AdmN7AjWDTzbGkbQBLTLWfaK4ftXckWTNAyMT1W2j3OvMSpohYoyyt1NM67JJwaF6_TyCVVYDXQZqa5RoO2IpVuHneQ13Y7RqH_8KY5Zm9YiexU10k8oaXILzhG_tGzt2Nzrb9GQ-UptuJNxWAoWPyDjFMb_Q9CrMRVzMzPTA2oQ_nuzMDtmY8_Z1EsODX92yLKUmX0WNdagV6vU" }
        };
        var content = new FormUrlEncodedContent(values);

        var response = await client.PutAsync("https://api.spotify.com/v1/me/player/pause", content);


        Console.WriteLine("Here");
        var responseString = await response.Content.ReadAsStringAsync();






    }

    public async 
    Task Idk(string response)
    {
        Console.WriteLine(response);
    }

}
