package io.swagger.client.model

import io.swagger.client.core.ApiModel
import org.joda.time.DateTime


case class ApiResponse (
  code: Option[Int],
  `type`: Option[String],
  message: Option[String])
   extends ApiModel


