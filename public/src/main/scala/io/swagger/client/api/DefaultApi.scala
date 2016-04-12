package io.swagger.client.api

import io.swagger.client.core._
import io.swagger.client.core.CollectionFormats._
import io.swagger.client.core.ApiKeyLocations._

object DefaultApi {

  /**
   * yupo
   * 
   * Expected answers:
   *   code 200 :  (OK)
   * 
   * @param firstname Enter the first name of the person you wish to find
   */
  def getGet(firstname: String): ApiRequest[Unit] =
    ApiRequest[Unit](ApiMethods.GET, "https://localhost", "/get", "application/json")
      .withQueryParam("firstname", firstname)
      .withSuccessResponse[Unit](200)
      

}

