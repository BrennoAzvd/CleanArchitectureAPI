﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitecture.Application.UseCases.UpdateUser
{
    public sealed record UpdateUserRequest(Guid Id,
                      string Email, string Name)
                      : IRequest<UpdateUserResponse>;
}
