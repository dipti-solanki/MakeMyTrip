import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class TrainAvailabilityDayBase {

//#region trainAvailableId Prop
        @prop()
        trainAvailableId : number;
//#endregion trainAvailableId Prop


//#region availableDay Prop
        @required()
        @maxLength({value:50})
        availableDay : string;
//#endregion availableDay Prop


//#region trainDetailId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        trainDetailId : number;
//#endregion trainDetailId Prop



}