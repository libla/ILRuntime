﻿using System;
using System.Collections.Generic;
using System.Reflection;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class ILRuntimeTest_TestFramework_TestStruct_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodInfo method;
            Type[] args;
            Type type = typeof(ILRuntimeTest.TestFramework.TestStruct);
            args = new Type[]{typeof(ILRuntimeTest.TestFramework.TestStruct).MakeByRefType()};
            method = type.GetMethod("DoTest", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DoTest_0);
            args = new Type[]{typeof(System.Int32).MakeByRefType()};
            method = type.GetMethod("DoTest", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DoTest_1);
            args = new Type[]{typeof(ILRuntimeTest.TestFramework.TestStruct)};
            method = type.GetMethod("DoTest2", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DoTest2_2);

        }

        static StackObject* DoTest_0(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            ILRuntimeTest.TestFramework.TestStruct a = (ILRuntimeTest.TestFramework.TestStruct)typeof(ILRuntimeTest.TestFramework.TestStruct).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));

            ILRuntimeTest.TestFramework.TestStruct.DoTest(ref a);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var dst = *(StackObject**)&ptr_of_this_method->Value;
                        __mStack[dst->Value] = a;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var obj = __mStack[ptr_of_this_method->Value];
                        if(obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)obj)[ptr_of_this_method->ValueLow] = a;
                        }
                        else
                        {
                            var t = domain.GetType(obj.GetType()) as CLRType;
                            t.Fields[ptr_of_this_method->ValueLow].SetValue(obj, a);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = a;
                        }
                        else
                        {
                            ((CLRType)t).Fields[ptr_of_this_method->ValueLow].SetValue(null, a);
                        }
                    }
                    break;
            }

            return __ret;
        }

        static StackObject* DoTest_1(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 a = ptr_of_this_method->Value;

            ILRuntimeTest.TestFramework.TestStruct.DoTest(ref a);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var dst = *(StackObject**)&ptr_of_this_method->Value;
                        dst->ObjectType = ObjectTypes.Integer;
                        dst->Value = a;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var obj = __mStack[ptr_of_this_method->Value];
                        if(obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)obj)[ptr_of_this_method->ValueLow] = a;
                        }
                        else
                        {
                            var t = domain.GetType(obj.GetType()) as CLRType;
                            t.Fields[ptr_of_this_method->ValueLow].SetValue(obj, a);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = a;
                        }
                        else
                        {
                            ((CLRType)t).Fields[ptr_of_this_method->ValueLow].SetValue(null, a);
                        }
                    }
                    break;
            }

            return __ret;
        }

        static StackObject* DoTest2_2(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ILRuntimeTest.TestFramework.TestStruct aaa = (ILRuntimeTest.TestFramework.TestStruct)typeof(ILRuntimeTest.TestFramework.TestStruct).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ILRuntimeTest.TestFramework.TestStruct.DoTest2(aaa);

            return __ret;
        }


    }
}
