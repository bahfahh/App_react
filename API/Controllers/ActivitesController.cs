using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API.Controllers
{
    #nullable disable
    public class ActivitiesController : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<ActivityRequestDTO>>> GetActivities()
        {
            System.Console.WriteLine(" controller/GetActivities().... ");
            return await Mediator.Send(new ActivitiesList.Query());
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityRequestDTO>> GetActivity(Guid id)
        {
            System.Console.WriteLine(" GetActivity id ");
            return await Mediator.Send(new Detail.Query { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> CreateActivity(ActivityRequestDTO activity)
        {
            return await Mediator.Send(new CreatActivity.Command { ActivityDTO=activity });
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> EditActivity(Guid id, ActivityRequestDTO activity)
        {   
            activity.Id = id;
            return await Mediator.Send(new EditActivity.Command { ActivityDTO = activity });
        }
        
    }

}