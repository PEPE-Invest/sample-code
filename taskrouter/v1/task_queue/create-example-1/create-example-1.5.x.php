<?php

// Update the path below to your autoload.php,
// see https://getcomposer.org/doc/01-basic-usage.md
require_once '/path/to/vendor/autoload.php';

use Twilio\Rest\Client;

// Your Account Sid and Auth Token from twilio.com/console
$sid    = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
$token  = "your_auth_token";
$twilio = new Client($sid, $token);

$task_queue = $twilio->taskrouter->v1->workspaces("WSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")
                                     ->taskQueues
                                     ->create("English",
                                              "WAea296a56ebce4bfbff0e99abadf16934",
                                              "WA21d51f4c72583766988f9860de3e130a",
                                              array(
                                                  "targetWorkers" => "languages HAS \"english\""
                                              )
                                     );

print($task_queue->sid);