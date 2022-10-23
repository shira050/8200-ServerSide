using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using DTO;
using System.IO;
using System.Net.Http.Headers;

namespace _8200HW.controllers
{
    [Route("api/[MembersController]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
       BLmembers _Ubl = new BLmembers();



        [HttpGet("/GetAllMembers")]
        public IActionResult GetAllMembers()
        {
            return Ok(_Ubl.GetAllMembers());
        }

        [HttpGet("/GetMember")]
        public IActionResult GetMember(string id)
        {
            return Ok(_Ubl.GetMember(id));
        }
        [HttpGet("/GetMemberDetails")]
        public IActionResult GetMemberDetails(string id)
        {
            return Ok(_Ubl.GetMemberDetails(id));
        }

        [HttpPost("/AddMember")]
        public IActionResult AddMember([FromBody] DTOmembers m)
        {

            return Ok(_Ubl.AddMember(m));
        }
        [HttpPut("/UppdateMember/{id}")]
        public IActionResult UppdateMember(string id,[FromBody] DTOmembers member)
        {
            return Ok(_Ubl.UppdateMember(member, id));
        }
        
        [HttpPut("/UppdateMemberProfile/{id}/{img}")]

        public IActionResult UppdateMemberProfile(string id,string img)
        {
            _Ubl.UppdateMemberProfile(id, img);
            return Ok();
        }

        [HttpPut("/UppdateMemberKoronaDetails/{id}")]

        public IActionResult UppdateMemberKoronaDetails(string id,[FromBody] DTOKoronaTable koronaD)
        {
            _Ubl.UppdateMemberKoronaDetails(id, koronaD);
            return Ok();
        }

        [HttpDelete("/RemoveMember/{id}")]
        public IActionResult RemoveMember(string id)
        {
            return Ok(_Ubl.RemoveMember(id));
        }

        [HttpGet("/GetAllMembersDoV1")]
        public IActionResult GetAllMembersDoV1()
        {
            return Ok(_Ubl.GetAllMembersDoV1());
        }
        [HttpGet("/GetAllMembersDoV2")]
        public IActionResult GetAllMembersDoV2()
        {
            return Ok(_Ubl.GetAllMembersDoV2());
        }
        [HttpGet("/GetAllMembersDoV3")]
        public IActionResult GetAllMembersDoV3()
        {
            return Ok(_Ubl.GetAllMembersDoV3());
        }
        [HttpGet("/GetAllMembersDoV4")]
        public IActionResult GetAllMembersDoV4()
        {
            return Ok(_Ubl.GetAllMembersDoV4());
        }


        //   גרף:
        [HttpGet("/AveragePos")]
        public IActionResult AveragePos()
        {
            var pos = _Ubl.AveragePos();
            if (pos != null)
                return Ok(pos);
            return NotFound();
        }




        [HttpGet("/GetCountNotV")]
        public IActionResult GetCountNotV()
        {
            return Ok(_Ubl.GetCountNotV());
        }




        ///העלאת תמונה
        public static string fName { get; set; }//משתנה שיכיל את שם הקובץ שיעלה
        [HttpPost("/upload"), DisableRequestSizeLimit]
        public IActionResult uploade()

        {
            try {
                var file = Request.Form.Files[0];

                var folderName = Path.Combine("wwwroot", "images");//)wwroot(הקובץ יאוחסן בתיקייה  שהכנתי מראש
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0) {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    fName = fileName.ToString();
                    //  XDocument d = XDocument.Load(@"C:\Users\user\Desktop\projectKavLekav_shira\ProjectKavLekav\ProjectKavLekav\wwwroot\images\" + fName);
                    string[] filePaths = Directory.GetFiles(@"C:\Users\user\Desktop\8200 shiraChadad\8200HW\8200HW\wwwroot\");
                   
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create)) {
                        file.CopyTo(stream);
                    }
                    return Ok(new { dbPath });

                }
                else {
                    return BadRequest();
                }


            }
            catch (Exception ex) {
                return StatusCode(500, $"Internal server error: {ex}");//שגיאה שתיזרק אם ההעלאה תיכשל
            }
        }
         }
}