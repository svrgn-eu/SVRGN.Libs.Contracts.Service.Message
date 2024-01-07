[TOC]

# About

This library delivers the interfaces for a wholesome message service. 

## IMessageService

The main service, which is managing the ITopics or channels. A MessageReceiver needs to register with this service in order to be on the list of receivers - otherwise the message will not be sent to this specific receiver.

## ITopic

The Topic represents a channel on which messages are exchanged. The interfaces tried to add control by holding the number of messages and list of receivers. The Topic implementation is responsible of delivering a message to 0 to n IMessageReceivers.

## IMessage

The message itself, as flexible as possible.

It holds a basic amount of minimum information like 

- Subject
- Payload
- Sender
- Recipients
- Control Dates (CreatedAt, SentAt)

Currently, there is no way of specifying the Type of the Payload, which means the receiving side has to validate and transform.



## IMessageReceiver

An IMessageReceiver needs to implement (mainly) the Receive() method, which gives the message, and as a result, expects a bool value if the message has been digested successfully.

Note: this can be checked by the concrete implementation, but the idea is to have one sender and n receivers, meaning it should not block sending the message to the next receiver in the topic message chain.

## IMessageSender

The Message Sender is responsible for sending the message. This is done in the conrete implementation by calling the IMessageService implementation.

## IMessageTransceiver

Bascically an IMessageSender and an IMessageReceiver combined. 



# How to use
Those interfaces are implemented in the package https://github.com/svrgn-eu/SVRGN.Libs.Implementations.Service.Message.