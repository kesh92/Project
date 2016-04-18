package io.swagger.api;

import io.swagger.model.*;
import io.swagger.api.GetApiService;
import io.swagger.api.factories.GetApiServiceFactory;

import io.swagger.annotations.ApiParam;

import com.sun.jersey.multipart.FormDataParam;


import java.util.List;
import io.swagger.api.NotFoundException;

import java.io.InputStream;

import com.sun.jersey.core.header.FormDataContentDisposition;
import com.sun.jersey.multipart.FormDataParam;

import javax.ws.rs.core.Context;
import javax.ws.rs.core.Response;
import javax.ws.rs.core.SecurityContext;
import javax.ws.rs.*;

@Path("/get")


@io.swagger.annotations.Api(description = "the get API")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaJerseyServerCodegen", date = "2016-04-18T18:08:32.257Z")
public class GetApi  {
   private final GetApiService delegate = GetApiServiceFactory.getGetApi();

    @GET
    
    
    
    @io.swagger.annotations.ApiOperation(value = "always", notes = "yupo", response = void.class, tags={  })
    @io.swagger.annotations.ApiResponses(value = { 
        @io.swagger.annotations.ApiResponse(code = 200, message = "OK", response = void.class) })
    public Response getGet(
        @ApiParam(value = "Enter the first name of the person you wish to find",required=true) @QueryParam("firstname") String firstname,
        @Context SecurityContext securityContext)
    throws NotFoundException {
        return delegate.getGet(firstname,securityContext);
    }
}
