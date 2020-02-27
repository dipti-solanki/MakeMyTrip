import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class FlightAvailabilityDayBase {

//#region flightAvailableId Prop
        @prop()
        flightAvailableId : number;
//#endregion flightAvailableId Prop


//#region availableDay Prop
        @required()
        @maxLength({value:50})
        availableDay : string;
//#endregion availableDay Prop


//#region flightDetailId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        flightDetailId : number;
//#endregion flightDetailId Prop



}