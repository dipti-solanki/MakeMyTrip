import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class AppUserBase {

//#region appUserId Prop
        @prop()
        appUserId : number;
//#endregion appUserId Prop


//#region mobileNumber Prop
        @required()
        mobileNumber : number;
//#endregion mobileNumber Prop


//#region emailId Prop
        @required()
        @maxLength({value:50})
        emailId : string;
//#endregion emailId Prop


//#region appPassword Prop
        @required()
        @maxLength({value:50})
        appPassword : string;
//#endregion appPassword Prop





}