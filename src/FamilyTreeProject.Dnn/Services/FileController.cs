﻿//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using System.Net;
using System.Net.Http;
using System.Web.Http;
using DotNetNuke.Services.FileSystem;
using DotNetNuke.Web.Api;

namespace FamilyTreeProject.Dnn.Services
{
    
    public class FileController : BaseController
    {
        [DnnAuthorize]
        [HttpGet]
        public HttpResponseMessage GetUserFolder()
        {
            var userFolder = FolderManager.Instance.GetUserFolder(UserInfo);

            return Request.CreateResponse(HttpStatusCode.OK, new { userFolderId = userFolder.FolderID });
        }

    }
}
