package io.swagger.client.api

import io.swagger.client.core._
import io.swagger.client.core.CollectionFormats._
import io.swagger.client.core.ApiKeyLocations._

object DefaultApi {

  /**
   * 
   * 
   * Expected answers:
   *   code 200 :  (Lists)
   * 
   * @param ids ID
   * @param `new` ID
   */
  def testPathIdsNewGet(ids: String, `new`: String): ApiRequest[Unit] =
    ApiRequest[Unit](ApiMethods.GET, "https://localhost", "/test-path/{ids}/{new}", "application/json")
      .withPathParam("ids", ids)
      .withPathParam("new", `new`)
      .withSuccessResponse[Unit](200)
      


}

