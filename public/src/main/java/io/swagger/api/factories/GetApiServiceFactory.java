package io.swagger.api.factories;

import io.swagger.api.GetApiService;
import io.swagger.api.impl.GetApiServiceImpl;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaJerseyServerCodegen", date = "2016-04-17T18:44:58.801Z")
public class GetApiServiceFactory {

   private final static GetApiService service = new GetApiServiceImpl();

   public static GetApiService getGetApi()
   {
      return service;
   }
}
