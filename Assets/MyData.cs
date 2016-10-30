/// <summary>
/// Luu du lieu nguoi dung theo session
/// </summary>
public class MySession
{
    //{
    // ses_id: 0,
    // use_id: 0,
    // ses_time_start: "",
    // ses_time_end: "",
    // ses_score: 0,
    // ses_status: ""
    //}
    public int ses_id { get; set; }
    public int use_id { get; set; }
    public string ses_time_start { get; set; }
    public string ses_time_end { get; set; }
    public int ses_score { get; set; }
    public string ses_status { get; set; }
}


public class Rootobject
{
    //{
	   // use_id: 0,
	   // use_first_name: "",
	   // use_last_name: "",
	   // use_dob: "",
	   // use_score: 0,
	   // use_level: 0,
	   // use_count_play: 0,
	   // created_at: "",
	   // use_status: ""
    //}

    public int use_id { get; set; }
    public string use_first_name { get; set; }
    public string use_last_name { get; set; }
    public string use_dob { get; set; }
    public int use_score { get; set; }
    public int use_level { get; set; }
    public int use_count_play { get; set; }
    public string created_at { get; set; }
    public string use_status { get; set; }
}


